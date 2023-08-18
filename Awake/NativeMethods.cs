using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Awake
{
    public static partial class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001

            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

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

        public static bool GetAwakeState()
        {
            EXECUTION_STATE currentState = NativeMethods.SetThreadExecutionState(NativeMethods.EXECUTION_STATE.ES_CONTINUOUS);
            SetThreadExecutionState(currentState);

            return currentState.HasFlag(EXECUTION_STATE.ES_DISPLAY_REQUIRED) &&
                currentState.HasFlag(EXECUTION_STATE.ES_SYSTEM_REQUIRED) &&
                currentState.HasFlag(EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }
    }
}
