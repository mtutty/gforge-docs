using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GForgeDocWindow.Util {
    public class StringHistoryList : List<string> {

        public int MaxCapacity { get; protected set; }

        public StringHistoryList(int maxCapacity) {
            if (maxCapacity < 1) throw new ArgumentOutOfRangeException(@"MaxCapacity", @"Max Capacity must be a number grater than zero.");
            this.MaxCapacity = maxCapacity;
        }

        public void ClearHistory() {
            this.Clear();
        }

        public void AddHistory(string item) {
            if (!this.Contains(item)) {
                this.Insert(0, item);
                while (this.Count > this.MaxCapacity) {
                    this.RemoveAt(this.Count - 1);
                }
            }
        }

        public string RecallHistory() {
            if (this.Count > 1) 
                this.RemoveAt(0);

            if (this.Count > 0)
                return this[0];

            return string.Empty;
        }
    }
}
