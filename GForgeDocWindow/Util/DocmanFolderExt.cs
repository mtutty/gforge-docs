using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GForgeDocWindow.Util {
    /// <summary>
    /// Extends the generated GForge Project class to allow for hierarchical
    /// stacking of project folders
    /// </summary>
   public partial class DocmanFolder {

       private IList<DocmanFolder> childFolders = new List<DocmanFolder>();

       public IList<DocmanFolder> ChildFolders { get { return this.childFolders; } }
    }
}
