using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milo
{
    internal class LoadingComponents
    {
        public void Progress_Tick(object sender, EventArgs e, MaterialProgressBar bar)
        {
            // Update the progress bar value
            if (bar.Value < bar.Maximum)
            {
                bar.Value += 1;
            }
        }

        public void ProgessText_Tick(object sender, EventArgs e, MaterialLabel label, string loadingText)
        {
            //Adding 1-3 Points between asending
            if (label.Text == loadingText)
            {
                label.Text = loadingText + ".";
            }
            else if (label.Text == loadingText + ".")
            {
                label.Text = loadingText + "..";
            }
            else if (label.Text == loadingText + "..")
            {
                label.Text = loadingText + "...";
            }
            else if (label.Text == loadingText + "...")
            {
                label.Text = loadingText;
            }
        }

    }

}
