namespace 카카오맵_API
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_kakao = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // listView_kakao
            // 
            this.listView_kakao.HideSelection = false;
            this.listView_kakao.Location = new System.Drawing.Point(1, 30);
            this.listView_kakao.MultiSelect = false;
            this.listView_kakao.Name = "listView_kakao";
            this.listView_kakao.Size = new System.Drawing.Size(276, 424);
            this.listView_kakao.TabIndex = 0;
            this.listView_kakao.UseCompatibleStateImageBehavior = false;
            this.listView_kakao.View = System.Windows.Forms.View.List;
            this.listView_kakao.SelectedIndexChanged += new System.EventHandler(this.listView_kakao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // tbox_search
            // 
            this.tbox_search.Location = new System.Drawing.Point(14, 5);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(99, 21);
            this.tbox_search.TabIndex = 2;
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(119, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(293, 34);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(491, 419);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_kakao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_kakao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

