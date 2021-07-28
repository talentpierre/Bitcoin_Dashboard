namespace Bitcoin_Dashboard
{
    partial class UserControl1
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.lblNrBlockTx = new System.Windows.Forms.Label();
            this.lblBlockHeight = new System.Windows.Forms.Label();
            this.lblBlocktime = new System.Windows.Forms.Label();
            this.lblBlockSize = new System.Windows.Forms.Label();
            this.lblBestBlock_ = new System.Windows.Forms.Label();
            this.lblBestBlock = new System.Windows.Forms.Label();
            this.lbl_blocksize = new System.Windows.Forms.Label();
            this.lbl_blocktime = new System.Windows.Forms.Label();
            this.lbl_nrTx = new System.Windows.Forms.Label();
            this.lbl_blockHeight = new System.Windows.Forms.Label();
            this.lblBlockchain = new System.Windows.Forms.Label();
            this.lblBlockchain_ = new System.Windows.Forms.Label();
            this.lblChain = new System.Windows.Forms.Label();
            this.lblSizeOnDisk = new System.Windows.Forms.Label();
            this.lblVerificationProcess = new System.Windows.Forms.Label();
            this.lblInitialBlockdownload = new System.Windows.Forms.Label();
            this.lbl_chain = new System.Windows.Forms.Label();
            this.lbl_sizeOnDisk = new System.Windows.Forms.Label();
            this.lbl_initialBlockdownload = new System.Windows.Forms.Label();
            this.lbl_verificationProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(448, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNrBlockTx
            // 
            this.lblNrBlockTx.AutoSize = true;
            this.lblNrBlockTx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrBlockTx.ForeColor = System.Drawing.Color.White;
            this.lblNrBlockTx.Location = new System.Drawing.Point(48, 373);
            this.lblNrBlockTx.Name = "lblNrBlockTx";
            this.lblNrBlockTx.Size = new System.Drawing.Size(96, 17);
            this.lblNrBlockTx.TabIndex = 25;
            this.lblNrBlockTx.Text = "Number of Tx:";
            // 
            // lblBlockHeight
            // 
            this.lblBlockHeight.AutoSize = true;
            this.lblBlockHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockHeight.ForeColor = System.Drawing.Color.White;
            this.lblBlockHeight.Location = new System.Drawing.Point(48, 403);
            this.lblBlockHeight.Name = "lblBlockHeight";
            this.lblBlockHeight.Size = new System.Drawing.Size(87, 17);
            this.lblBlockHeight.TabIndex = 24;
            this.lblBlockHeight.Text = "Blockheight:";
            // 
            // lblBlocktime
            // 
            this.lblBlocktime.AutoSize = true;
            this.lblBlocktime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlocktime.ForeColor = System.Drawing.Color.White;
            this.lblBlocktime.Location = new System.Drawing.Point(48, 343);
            this.lblBlocktime.Name = "lblBlocktime";
            this.lblBlocktime.Size = new System.Drawing.Size(75, 17);
            this.lblBlocktime.TabIndex = 23;
            this.lblBlocktime.Text = "Blocktime:";
            // 
            // lblBlockSize
            // 
            this.lblBlockSize.AutoSize = true;
            this.lblBlockSize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockSize.ForeColor = System.Drawing.Color.White;
            this.lblBlockSize.Location = new System.Drawing.Point(48, 313);
            this.lblBlockSize.Name = "lblBlockSize";
            this.lblBlockSize.Size = new System.Drawing.Size(68, 17);
            this.lblBlockSize.TabIndex = 22;
            this.lblBlockSize.Text = "Blocksize:";
            // 
            // lblBestBlock_
            // 
            this.lblBestBlock_.AutoSize = true;
            this.lblBestBlock_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestBlock_.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblBestBlock_.Location = new System.Drawing.Point(46, 283);
            this.lblBestBlock_.Name = "lblBestBlock_";
            this.lblBestBlock_.Size = new System.Drawing.Size(582, 17);
            this.lblBestBlock_.TabIndex = 21;
            this.lblBestBlock_.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // lblBestBlock
            // 
            this.lblBestBlock.AutoSize = true;
            this.lblBestBlock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestBlock.ForeColor = System.Drawing.Color.White;
            this.lblBestBlock.Location = new System.Drawing.Point(48, 266);
            this.lblBestBlock.Name = "lblBestBlock";
            this.lblBestBlock.Size = new System.Drawing.Size(75, 17);
            this.lblBestBlock.TabIndex = 20;
            this.lblBestBlock.Text = "Best Block:";
            // 
            // lbl_blocksize
            // 
            this.lbl_blocksize.AutoSize = true;
            this.lbl_blocksize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blocksize.ForeColor = System.Drawing.Color.White;
            this.lbl_blocksize.Location = new System.Drawing.Point(208, 313);
            this.lbl_blocksize.Name = "lbl_blocksize";
            this.lbl_blocksize.Size = new System.Drawing.Size(78, 17);
            this.lbl_blocksize.TabIndex = 26;
            this.lbl_blocksize.Text = "__________";
            // 
            // lbl_blocktime
            // 
            this.lbl_blocktime.AutoSize = true;
            this.lbl_blocktime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blocktime.ForeColor = System.Drawing.Color.White;
            this.lbl_blocktime.Location = new System.Drawing.Point(208, 343);
            this.lbl_blocktime.Name = "lbl_blocktime";
            this.lbl_blocktime.Size = new System.Drawing.Size(78, 17);
            this.lbl_blocktime.TabIndex = 27;
            this.lbl_blocktime.Text = "__________";
            // 
            // lbl_nrTx
            // 
            this.lbl_nrTx.AutoSize = true;
            this.lbl_nrTx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nrTx.ForeColor = System.Drawing.Color.White;
            this.lbl_nrTx.Location = new System.Drawing.Point(208, 373);
            this.lbl_nrTx.Name = "lbl_nrTx";
            this.lbl_nrTx.Size = new System.Drawing.Size(78, 17);
            this.lbl_nrTx.TabIndex = 28;
            this.lbl_nrTx.Text = "__________";
            // 
            // lbl_blockHeight
            // 
            this.lbl_blockHeight.AutoSize = true;
            this.lbl_blockHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blockHeight.ForeColor = System.Drawing.Color.White;
            this.lbl_blockHeight.Location = new System.Drawing.Point(208, 403);
            this.lbl_blockHeight.Name = "lbl_blockHeight";
            this.lbl_blockHeight.Size = new System.Drawing.Size(78, 17);
            this.lbl_blockHeight.TabIndex = 29;
            this.lbl_blockHeight.Text = "__________";
            // 
            // lblBlockchain
            // 
            this.lblBlockchain.AutoSize = true;
            this.lblBlockchain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockchain.ForeColor = System.Drawing.Color.White;
            this.lblBlockchain.Location = new System.Drawing.Point(48, 59);
            this.lblBlockchain.Name = "lblBlockchain";
            this.lblBlockchain.Size = new System.Drawing.Size(82, 17);
            this.lblBlockchain.TabIndex = 14;
            this.lblBlockchain.Text = "Blockchain:";
            // 
            // lblBlockchain_
            // 
            this.lblBlockchain_.AutoSize = true;
            this.lblBlockchain_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockchain_.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblBlockchain_.Location = new System.Drawing.Point(46, 76);
            this.lblBlockchain_.Name = "lblBlockchain_";
            this.lblBlockchain_.Size = new System.Drawing.Size(582, 17);
            this.lblBlockchain_.TabIndex = 15;
            this.lblBlockchain_.Text = "_________________________________________________________________________________" +
    "_";
            // 
            // lblChain
            // 
            this.lblChain.AutoSize = true;
            this.lblChain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChain.ForeColor = System.Drawing.Color.White;
            this.lblChain.Location = new System.Drawing.Point(48, 106);
            this.lblChain.Name = "lblChain";
            this.lblChain.Size = new System.Drawing.Size(51, 17);
            this.lblChain.TabIndex = 16;
            this.lblChain.Text = "Chain:";
            // 
            // lblSizeOnDisk
            // 
            this.lblSizeOnDisk.AutoSize = true;
            this.lblSizeOnDisk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeOnDisk.ForeColor = System.Drawing.Color.White;
            this.lblSizeOnDisk.Location = new System.Drawing.Point(48, 136);
            this.lblSizeOnDisk.Name = "lblSizeOnDisk";
            this.lblSizeOnDisk.Size = new System.Drawing.Size(84, 17);
            this.lblSizeOnDisk.TabIndex = 17;
            this.lblSizeOnDisk.Text = "Size on disk:";
            // 
            // lblVerificationProcess
            // 
            this.lblVerificationProcess.AutoSize = true;
            this.lblVerificationProcess.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificationProcess.ForeColor = System.Drawing.Color.White;
            this.lblVerificationProcess.Location = new System.Drawing.Point(48, 196);
            this.lblVerificationProcess.Name = "lblVerificationProcess";
            this.lblVerificationProcess.Size = new System.Drawing.Size(64, 17);
            this.lblVerificationProcess.TabIndex = 18;
            this.lblVerificationProcess.Text = "Progress:";
            // 
            // lblInitialBlockdownload
            // 
            this.lblInitialBlockdownload.AutoSize = true;
            this.lblInitialBlockdownload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialBlockdownload.ForeColor = System.Drawing.Color.White;
            this.lblInitialBlockdownload.Location = new System.Drawing.Point(48, 166);
            this.lblInitialBlockdownload.Name = "lblInitialBlockdownload";
            this.lblInitialBlockdownload.Size = new System.Drawing.Size(152, 17);
            this.lblInitialBlockdownload.TabIndex = 19;
            this.lblInitialBlockdownload.Text = "Initial Blockdownload:";
            // 
            // lbl_chain
            // 
            this.lbl_chain.AutoSize = true;
            this.lbl_chain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chain.ForeColor = System.Drawing.Color.White;
            this.lbl_chain.Location = new System.Drawing.Point(206, 106);
            this.lbl_chain.Name = "lbl_chain";
            this.lbl_chain.Size = new System.Drawing.Size(78, 17);
            this.lbl_chain.TabIndex = 30;
            this.lbl_chain.Text = "__________";
            // 
            // lbl_sizeOnDisk
            // 
            this.lbl_sizeOnDisk.AutoSize = true;
            this.lbl_sizeOnDisk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sizeOnDisk.ForeColor = System.Drawing.Color.White;
            this.lbl_sizeOnDisk.Location = new System.Drawing.Point(206, 136);
            this.lbl_sizeOnDisk.Name = "lbl_sizeOnDisk";
            this.lbl_sizeOnDisk.Size = new System.Drawing.Size(78, 17);
            this.lbl_sizeOnDisk.TabIndex = 31;
            this.lbl_sizeOnDisk.Text = "__________";
            // 
            // lbl_initialBlockdownload
            // 
            this.lbl_initialBlockdownload.AutoSize = true;
            this.lbl_initialBlockdownload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_initialBlockdownload.ForeColor = System.Drawing.Color.White;
            this.lbl_initialBlockdownload.Location = new System.Drawing.Point(206, 166);
            this.lbl_initialBlockdownload.Name = "lbl_initialBlockdownload";
            this.lbl_initialBlockdownload.Size = new System.Drawing.Size(78, 17);
            this.lbl_initialBlockdownload.TabIndex = 32;
            this.lbl_initialBlockdownload.Text = "__________";
            // 
            // lbl_verificationProgress
            // 
            this.lbl_verificationProgress.AutoSize = true;
            this.lbl_verificationProgress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificationProgress.ForeColor = System.Drawing.Color.White;
            this.lbl_verificationProgress.Location = new System.Drawing.Point(206, 196);
            this.lbl_verificationProgress.Name = "lbl_verificationProgress";
            this.lbl_verificationProgress.Size = new System.Drawing.Size(78, 17);
            this.lbl_verificationProgress.TabIndex = 33;
            this.lbl_verificationProgress.Text = "__________";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 226);
            this.progressBar1.Maximum = 1000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 34;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_verificationProgress);
            this.Controls.Add(this.lbl_initialBlockdownload);
            this.Controls.Add(this.lbl_sizeOnDisk);
            this.Controls.Add(this.lbl_chain);
            this.Controls.Add(this.lbl_blockHeight);
            this.Controls.Add(this.lbl_nrTx);
            this.Controls.Add(this.lbl_blocktime);
            this.Controls.Add(this.lbl_blocksize);
            this.Controls.Add(this.lblNrBlockTx);
            this.Controls.Add(this.lblBlockHeight);
            this.Controls.Add(this.lblBlocktime);
            this.Controls.Add(this.lblBlockSize);
            this.Controls.Add(this.lblBestBlock_);
            this.Controls.Add(this.lblBestBlock);
            this.Controls.Add(this.lblInitialBlockdownload);
            this.Controls.Add(this.lblVerificationProcess);
            this.Controls.Add(this.lblSizeOnDisk);
            this.Controls.Add(this.lblChain);
            this.Controls.Add(this.lblBlockchain_);
            this.Controls.Add(this.lblBlockchain);
            this.Controls.Add(this.button2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(742, 558);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNrBlockTx;
        private System.Windows.Forms.Label lblBlockHeight;
        private System.Windows.Forms.Label lblBlocktime;
        private System.Windows.Forms.Label lblBlockSize;
        private System.Windows.Forms.Label lblBestBlock_;
        private System.Windows.Forms.Label lblBestBlock;
        private System.Windows.Forms.Label lbl_blocksize;
        private System.Windows.Forms.Label lbl_blocktime;
        private System.Windows.Forms.Label lbl_nrTx;
        private System.Windows.Forms.Label lbl_blockHeight;
        private System.Windows.Forms.Label lblBlockchain;
        private System.Windows.Forms.Label lblBlockchain_;
        private System.Windows.Forms.Label lblChain;
        private System.Windows.Forms.Label lblSizeOnDisk;
        private System.Windows.Forms.Label lblVerificationProcess;
        private System.Windows.Forms.Label lblInitialBlockdownload;
        private System.Windows.Forms.Label lbl_chain;
        private System.Windows.Forms.Label lbl_sizeOnDisk;
        private System.Windows.Forms.Label lbl_initialBlockdownload;
        private System.Windows.Forms.Label lbl_verificationProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
