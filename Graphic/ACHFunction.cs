using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class ACHFunction :KotelnikovFunction
    {
        List<Complex> listOfHarminics;

        public ACHFunction(Function InpFunction) : base(InpFunction)
        {           
            listOfHarminics = DPF.GetDpf(InpFunction, 100);
            for (int i = 0; i < listOfHarminics.Count - 1; i++)
            {
                Add(new System.Drawing.PointF(i, (float)listOfHarminics[i].Magnitude));
            }
        }
    }
}
