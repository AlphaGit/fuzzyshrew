using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FuzzyShrew.Model.Plugin.Formats;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public partial class FrmCsvConfigurationForm : FormatConfigurationFormBase
    {
        private CsvExportFormat _format;
        private Dictionary<TreeNode, CsvField> _nodes;

        public FrmCsvConfigurationForm(CsvExportFormat format)
            : base(format)
        {
            InitializeComponent();
            _format = (CsvExportFormat)format;
            _nodes = new Dictionary<TreeNode, CsvField>();

            SetInitialValues(_format.Configuration);
        }

        private void SetInitialValues(CsvExportFormatConfiguration configuration)
        {
            chkShowTitles.Checked = configuration.ShowTitles;
            chkUseQuotationMarksForAll.Checked = configuration.UseQuotationMarksForAll;
            RenegerateFieldsTree(configuration.FieldTreeRoot);
        }

        private void RenegerateFieldsTree(CsvField csvField)
        {
            tvPropertiesTree.Nodes.Clear();
            _nodes.Clear();

            var node = tvPropertiesTree.Nodes.Add(csvField.FieldName + "(" + csvField.ClassType.Name + ")");
            _nodes.Add(node, csvField);
            AddChildrenNodes(node, csvField.ChildFields);
        }

        private void AddChildrenNodes(TreeNode node, List<CsvField> list)
        {
            foreach (var field in list)
            {
                var childNode = node.Nodes.Add(field.FieldName + "(" + field.ClassType.Name + ")");
                
                _nodes.Add(childNode, field);
                AddChildrenNodes(childNode, field.ChildFields);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void chkShowTitles_CheckedChanged(object sender, EventArgs e)
        {
            _format.Configuration.ShowTitles = chkShowTitles.Checked;
        }

        private void chkUseQuotationMarksForAll_CheckedChanged(object sender, EventArgs e)
        {
            _format.Configuration.UseQuotationMarksForAll = chkUseQuotationMarksForAll.Checked;
        }

        private void tvPropertiesTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var field = _nodes[e.Node];
            if (field.ChildFields.Count == 0)
            {
                field.PopulateChildFields();
                AddChildrenNodes(e.Node, field.ChildFields);
            }

            e.Node.Toggle();
        }

        private void tvPropertiesTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            var field = _nodes[e.Node];
            field.ShowField = e.Node.Checked;
        }
    }
}
