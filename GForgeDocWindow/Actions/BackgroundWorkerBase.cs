using System.ComponentModel;
using System;

namespace GForgeDocWindow.Actions {
    public abstract class BackgroundWorkerBase : BackgroundWorker {

        public string Error { get; set; }

        public int PercentComplete { get; protected set; }
        public int Increment { get; protected set; }
        protected DoWorkEventArgs DoWorkEventArgs { get; set; }

        public BackgroundWorkerBase() {
            this.DoWork += new DoWorkEventHandler(BackgroundWorkerBase_DoWork);
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;
        }

        public BackgroundWorkerBase(int increment) {
            this.Increment = increment;
        }

        void BackgroundWorkerBase_DoWork(object sender, DoWorkEventArgs e) {
            try {
                this.DoWorkEventArgs = e;
                this.Work();
            } catch (Exception ex) {
                this.Error = ex.Message;
                throw;
            }            
        }

        public abstract void Work();

        protected bool ShouldContinue() {
            if (this.CancellationPending) {
                if (this.DoWorkEventArgs != null) this.DoWorkEventArgs.Cancel = true;
                return false;
            }
            return true;
        }

        protected bool CheckProgress(int percentComplete, string template, params object[] values) {
            this.PercentComplete = percentComplete;
            return CheckProgress(string.Format(template, values));
        }

        protected bool CheckProgress(string template, params object[] values) {
            return CheckProgress(string.Format(template, values));
        }

        protected bool CheckProgress(string msg) {
            this.ReportProgress(this.PercentComplete, msg);
            return this.ShouldContinue();
        }

        protected bool IncrementProgress(string template, params object[] values) {
            return IncrementProgress(string.Format(template, values));
        }

        protected bool IncrementProgress(string msg) {
            this.PercentComplete += this.Increment;
            this.ReportProgress(this.PercentComplete, msg);
            return this.ShouldContinue();
        }


    }
}
