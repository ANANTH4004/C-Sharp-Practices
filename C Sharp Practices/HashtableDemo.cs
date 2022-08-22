using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    public partial class HashtableDemo : Component
    {
        public HashtableDemo()
        {
            InitializeComponent();
        }

        public HashtableDemo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
