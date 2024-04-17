using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VAPW_Car_Wash.Gero_CarWash;

namespace VAPW_Car_Wash;

public class CarWashDTO
{
    public bool InputVrataOpen { get; private set; }
    public bool OutputVrataOpen { get; private set; }
    public Semafor InputSemafor { get; private set; }
    public Semafor OutputSemafor { get; private set; }

    public CarWashDTO(bool inputVrataOpen, bool outputVrataOpen, Semafor inputSemafor, Semafor outputSemafor)
    {
        InputVrataOpen = inputVrataOpen;
        OutputVrataOpen = outputVrataOpen;
        InputSemafor = inputSemafor;
        OutputSemafor = outputSemafor;
    }
}
