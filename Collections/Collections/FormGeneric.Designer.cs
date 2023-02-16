﻿namespace Collections
{
    partial class FormGeneric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 29;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(592, 526);
            this.list.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(625, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(145, 54);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSet.Location = new System.Drawing.Point(625, 72);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(145, 54);
            this.btnHashSet.TabIndex = 1;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionary.Location = new System.Drawing.Point(625, 132);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(145, 54);
            this.btnDictionary.TabIndex = 1;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedList.Location = new System.Drawing.Point(625, 192);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(145, 54);
            this.btnSortedList.TabIndex = 1;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedDictionary.Location = new System.Drawing.Point(625, 252);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(145, 54);
            this.btnSortedDictionary.TabIndex = 2;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.UseVisualStyleBackColor = true;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedSet.Location = new System.Drawing.Point(625, 312);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(145, 54);
            this.btnSortedSet.TabIndex = 3;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(625, 372);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(145, 54);
            this.btnQueue.TabIndex = 4;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.Location = new System.Drawing.Point(625, 432);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(145, 54);
            this.btnStack.TabIndex = 5;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(625, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 54);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortedDictionary);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.list);
            this.Name = "FormGeneric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Lists";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnClear;
    }
}

