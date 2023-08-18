using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awake
{
    public class PowerHelper
    {
        public static void ForceSystemAwake()
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS |
                                              NativeMethods.EXECUTION_STATE.ES_DISPLAY_REQUIRED |
                                              NativeMethods.EXECUTION_STATE.ES_SYSTEM_REQUIRED |
                                              NativeMethods.EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }

        public static void ResetSystemDefault()
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS);
        }
    }
}
