namespace MySolution.Module.Controllers {
    partial class MyViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MySimpleAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // MySimpleAction
            // 
            this.MySimpleAction.Caption = "My Simple Action";
            this.MySimpleAction.Category = "MyCategory";
            this.MySimpleAction.ConfirmationMessage = null;
            this.MySimpleAction.Id = "MySimpleAction";
            this.MySimpleAction.ToolTip = null;
            this.MySimpleAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.MySimpleAction_Execute);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction MySimpleAction;
    }
}
