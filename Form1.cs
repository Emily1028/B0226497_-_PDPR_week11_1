using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace B0226497_段昱如_PDPR_week11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "";
        Random rnd = new Random();
        private void ARRAY_Click(object sender, EventArgs e)
        {
            
            BOX[] arrayBOX = new BOX[10];
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                arrayBOX[totalBOX] = new BOX(totalBOX , rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                str += $"\n{arrayBOX[totalBOX].showME()}";
            }
            lblRESULT.Text = str;
        }

        private void DICTIONARYG_Click(object sender, EventArgs e)
        {
            Dictionary<int, BOX> dictionaryBOX = new Dictionary<int, BOX>();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                dictionaryBOX.Add(box.id, box);
            }
            foreach (KeyValuePair<int, BOX> item in dictionaryBOX)
            {
                int itemkey = item.Key;
                BOX box = (BOX)item.Value;
                str += $"\n{box.showME()}";
            }
            lblRESULT.Text = str;
        }

        private void STACK_Click(object sender, EventArgs e)
        {
            Stack stackBOX = new Stack();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                stackBOX.Push(box);
            }
            while (stackBOX.Count > 0)
            {
                var item = stackBOX.Pop();
                str += $"\n{((BOX)item).showME()}";
            }
            lblRESULT.Text = str;
        }

        private void QUEUE_Click(object sender, EventArgs e)
        {
            Queue queueBOX = new Queue();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                queueBOX.Enqueue(box);
            }
            while (queueBOX.Count > 0)
            {
                BOX box = (BOX)queueBOX.Dequeue();
                str += $"\n{box.showME()}";
            }
            lblRESULT.Text = str;
        }

        private void HASHTABLE_Click(object sender, EventArgs e)
        {
            Hashtable hashtableBOX = new Hashtable();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                hashtableBOX.Add(box.id, box);
            }
            foreach (DictionaryEntry item in hashtableBOX)
            {
                int itemkey = (int)item.Key;
                BOX box = (BOX)item.Value;
                str += $"\n{box.showME()}";
            }
            lblRESULT.Text = str;
        }

        private void ARRAYLIST_Click(object sender, EventArgs e)
        {
            ArrayList arraylistBOX = new ArrayList();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                arraylistBOX.Add(box);
            }
            foreach (var item in arraylistBOX)
                str += $"\n{((BOX)item).showME()}";
            lblRESULT.Text = str;
        }

        private void STACKG_Click(object sender, EventArgs e)
        {
            Stack<BOX> stackgBOX = new Stack<BOX>();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                stackgBOX.Push(box);
            }
            while (stackgBOX.Count > 0)
            {
                var item = stackgBOX.Pop();
                str += $"\n{((BOX)item).showME()}";
            }
            lblRESULT.Text = str;
        }

        private void QUEUEG_Click(object sender, EventArgs e)
        {
            Queue<BOX> queuegBOX = new Queue<BOX>();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                queuegBOX.Enqueue(box);
            }
            while (queuegBOX.Count > 0)
            {
                str += $"\n{queuegBOX.Dequeue().showME()}";
            }
            lblRESULT.Text = str;
        }

        private void SORTEDLIST_Click(object sender, EventArgs e)
        {
            SortedList sortedlistBOX = new SortedList();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                sortedlistBOX.Add(box.id, box);
            }
            foreach (DictionaryEntry item in sortedlistBOX)
            {
                int itemkey = (int)item.Key;
                BOX box = (BOX)item.Value;
                str += $"\n{box.showME()}";
            }
            lblRESULT.Text = str;
        }

        private void LISTG_Click(object sender, EventArgs e)
        {
            List<BOX> listgBOX = new List<BOX>();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                listgBOX.Add(box);
            }
            foreach (var item in listgBOX)
                str += $"\n{((BOX)item).showME()}";
            lblRESULT.Text = str;
        }

        private void SORTEDLISTG_Click(object sender, EventArgs e)
        {
            SortedList<int, BOX> sortedlistgBOX = new SortedList<int, BOX>();
            for (int totalBOX = 0; totalBOX < 10; totalBOX++)
            {
                BOX box = new BOX(totalBOX, rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                sortedlistgBOX.Add(box.id, box);
            }
            foreach (KeyValuePair<int, BOX> item in sortedlistgBOX)
            {
                int itemkey = item.Key;
                BOX box = (BOX)item.Value;
                str += $"\n{box.showME()}";
            }
            lblRESULT.Text = str;
        }
    }
}
