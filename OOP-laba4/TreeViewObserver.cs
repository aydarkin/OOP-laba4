using OOP_laba4.Figures;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_laba4
{
    class TreeViewObserver : TreeView, IObserver
    {
        public Storage<Figure> Figures;
        public TreeViewObserver() : base()
        {
            CheckBoxes = true;
        }

        List<IObservable> subjects = new List<IObservable>();
        public List<IObservable> GetSubjects()
        {
            return subjects;
        }

        public void OnPropertyChanged(IObservable subject, string property = null, object[] args = null)
        {
            this.Nodes.Clear();
            if (subject is Storage<Figure> figures)
            {
                this.Figures = figures;
                FillNode(figures, this.Nodes);
            }        
        }

        void FillNode(Storage<Figure> figures, TreeNodeCollection nodes)
        {
            TreeNode node;
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                node = nodes.Add(it.GetCurrent().Value.ToString());
                node.Checked = it.GetCurrent().Value.Selected;

                if (it.GetCurrent().Value is GroupedFigures group)
                    FillNode(group.figures, node.Nodes);
            }
        }
    }
}
