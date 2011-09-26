using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GForgeDocWindow.Util {
    public class StringHistoryList : List<string> {

        public int MaxCapacity { get; protected set; }
        public int HistoryIndex { get; protected set; }

        public StringHistoryList(int maxCapacity) {
            if (maxCapacity < 1) throw new ArgumentOutOfRangeException(@"MaxCapacity", @"Max Capacity must be a number greater than zero.");
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
            this.HistoryIndex = 0;
        }

        public bool CanGoBack {
            get {
                if (this.HistoryIndex < (this.Count - 1)) return true;
                return false;
            }
        }

        public bool CanGoForward {
            get {
                if (this.HistoryIndex > 0) return true;
                return false;
            }
        }

        public string GoBack() {
            if (this.CanGoBack) this.HistoryIndex += 1;
            return this.CurrentItem;
        }

        public string GoForward() {
            if (this.CanGoForward) this.HistoryIndex -= 1;
            return this.CurrentItem;
        }

        public string CurrentItem {
            get {
                if (this.Count > this.HistoryIndex)
                    return this[this.HistoryIndex];
                return string.Empty;
            }
        }
    }
}
