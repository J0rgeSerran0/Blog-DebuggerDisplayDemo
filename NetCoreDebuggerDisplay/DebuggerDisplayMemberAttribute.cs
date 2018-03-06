using System;

namespace NetCoreDebuggerDisplay
{
    public class DebuggerDisplayMemberAttribute : Attribute
    {
        private bool _debuggerDisplay;

        public bool DebuggerDisplay { get { return _debuggerDisplay; } }

        public DebuggerDisplayMemberAttribute(bool debuggerDisplay = true)
        {
            _debuggerDisplay = debuggerDisplay;
        }
    }

}