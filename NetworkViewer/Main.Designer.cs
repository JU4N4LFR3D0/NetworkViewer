using System.Windows.Forms;

namespace NetworkViewer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.netdataGridView = new System.Windows.Forms.DataGridView();
            this.net_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.send_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_timer = new System.Windows.Forms.Timer(this.components);
            this.net_tabControl = new System.Windows.Forms.TabControl();
            this.table_tabPage = new System.Windows.Forms.TabPage();
            this.plot_tabPage = new System.Windows.Forms.TabPage();
            this.net_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.speed_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.speed_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.interface_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.interface_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.status_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.netdataGridView)).BeginInit();
            this.net_tabControl.SuspendLayout();
            this.table_tabPage.SuspendLayout();
            this.plot_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.net_chart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // netdataGridView
            // 
            this.netdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.netdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.netdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.net_id,
            this.net_col,
            this.net_type,
            this.received_col,
            this.send_col});
            this.netdataGridView.Location = new System.Drawing.Point(0, 0);
            this.netdataGridView.Name = "netdataGridView";
            this.netdataGridView.RowTemplate.Height = 25;
            this.netdataGridView.Size = new System.Drawing.Size(776, 482);
            this.netdataGridView.TabIndex = 0;
            // 
            // net_id
            // 
            this.net_id.HeaderText = "ID";
            this.net_id.Name = "net_id";
            this.net_id.ReadOnly = true;
            // 
            // net_col
            // 
            this.net_col.HeaderText = "Network";
            this.net_col.Name = "net_col";
            this.net_col.ReadOnly = true;
            // 
            // net_type
            // 
            this.net_type.HeaderText = "Type";
            this.net_type.Name = "net_type";
            this.net_type.ReadOnly = true;
            // 
            // received_col
            // 
            this.received_col.HeaderText = "Received";
            this.received_col.Name = "received_col";
            this.received_col.ReadOnly = true;
            // 
            // send_col
            // 
            this.send_col.HeaderText = "Send";
            this.send_col.Name = "send_col";
            this.send_col.ReadOnly = true;
            // 
            // net_timer
            // 
            this.net_timer.Interval = 1000;
            this.net_timer.Tick += new System.EventHandler(this.net_timer_Tick);
            // 
            // net_tabControl
            // 
            this.net_tabControl.Controls.Add(this.table_tabPage);
            this.net_tabControl.Controls.Add(this.plot_tabPage);
            this.net_tabControl.Location = new System.Drawing.Point(0, 28);
            this.net_tabControl.Name = "net_tabControl";
            this.net_tabControl.SelectedIndex = 0;
            this.net_tabControl.Size = new System.Drawing.Size(784, 508);
            this.net_tabControl.TabIndex = 2;
            // 
            // table_tabPage
            // 
            this.table_tabPage.Controls.Add(this.netdataGridView);
            this.table_tabPage.Location = new System.Drawing.Point(4, 22);
            this.table_tabPage.Name = "table_tabPage";
            this.table_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.table_tabPage.Size = new System.Drawing.Size(776, 482);
            this.table_tabPage.TabIndex = 0;
            this.table_tabPage.Text = "Table";
            this.table_tabPage.UseVisualStyleBackColor = true;
            // 
            // plot_tabPage
            // 
            this.plot_tabPage.Controls.Add(this.net_chart);
            this.plot_tabPage.Location = new System.Drawing.Point(4, 22);
            this.plot_tabPage.Name = "plot_tabPage";
            this.plot_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.plot_tabPage.Size = new System.Drawing.Size(776, 482);
            this.plot_tabPage.TabIndex = 1;
            this.plot_tabPage.Text = "Plot";
            this.plot_tabPage.UseVisualStyleBackColor = true;
            // 
            // net_chart
            // 
            this.net_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "netChartArea";
            this.net_chart.ChartAreas.Add(chartArea1);
            this.net_chart.Location = new System.Drawing.Point(0, 0);
            this.net_chart.Name = "net_chart";
            this.net_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.net_chart.Size = new System.Drawing.Size(776, 482);
            this.net_chart.TabIndex = 0;
            this.net_chart.Text = "Chart";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel.Text = "ju4n4lfr3d0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speed_toolStripLabel,
            this.speed_toolStripComboBox,
            this.interface_toolStripLabel,
            this.interface_toolStripComboBox,
            this.status_toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // speed_toolStripLabel
            // 
            this.speed_toolStripLabel.Name = "speed_toolStripLabel";
            this.speed_toolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.speed_toolStripLabel.Text = "Speed";
            // 
            // speed_toolStripComboBox
            // 
            this.speed_toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed_toolStripComboBox.Items.AddRange(new object[] {
            "B/s",
            "b/s",
            "KB/s",
            "Kb/s",
            "MB/s",
            "Mb/s"});
            this.speed_toolStripComboBox.Name = "speed_toolStripComboBox";
            this.speed_toolStripComboBox.Size = new System.Drawing.Size(104, 25);
            this.speed_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.speed_toolStripComboBox_SelectedIndexChanged);
            // 
            // interface_toolStripLabel
            // 
            this.interface_toolStripLabel.Name = "interface_toolStripLabel";
            this.interface_toolStripLabel.Size = new System.Drawing.Size(53, 22);
            this.interface_toolStripLabel.Text = "Interface";
            // 
            // interface_toolStripComboBox
            // 
            this.interface_toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interface_toolStripComboBox.Name = "interface_toolStripComboBox";
            this.interface_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.interface_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.interface_toolStripComboBox_SelectedIndexChanged);
            // 
            // status_toolStripLabel
            // 
            this.status_toolStripLabel.Name = "status_toolStripLabel";
            this.status_toolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.status_toolStripLabel.Text = "Status:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.net_tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "NetViewer";
            ((System.ComponentModel.ISupportInitialize)(this.netdataGridView)).EndInit();
            this.net_tabControl.ResumeLayout(false);
            this.table_tabPage.ResumeLayout(false);
            this.plot_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.net_chart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView netdataGridView;
        private System.Windows.Forms.Timer net_timer;
        private DataGridViewTextBoxColumn net_id;
        private DataGridViewTextBoxColumn net_col;
        private DataGridViewTextBoxColumn net_type;
        private DataGridViewTextBoxColumn received_col;
        private DataGridViewTextBoxColumn send_col;
        private TabControl net_tabControl;
        private TabPage table_tabPage;
        private TabPage plot_tabPage;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart net_chart;
        private ToolStrip toolStrip1;
        private ToolStripLabel speed_toolStripLabel;
        private ToolStripComboBox speed_toolStripComboBox;
        private ToolStripLabel interface_toolStripLabel;
        private ToolStripComboBox interface_toolStripComboBox;
        private ToolStripLabel status_toolStripLabel;
    }
}