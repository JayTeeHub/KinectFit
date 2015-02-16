using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

public class KinectClass
{
    public int[] Measurements { get; set; }
    public String firstMeasure { get; set; }
    public String secondMeasure { get; set; }
    
    public KinectClass(string _meas1, string _meas2)
    {
        firstMeasure = _meas1;
        secondMeasure = _meas2;
        
        MessageBox.Show("first measurement will be done on the: " + firstMeasure);
        MessageBox.Show("second measurement will be done on the: " + firstMeasure);

    }

    public int[] PerformScan()
    {
        return Measurements;
    }

}

