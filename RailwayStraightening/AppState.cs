using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayStraightening
{
    public class AppState
    {
        private static AppState _appStateInternal;

        public static AppState GetState => _appStateInternal == null ? CreateStateInstanceAndReturn() : _appStateInternal;

        public AppState()
        {
            MeasuredDataInputBoxesState = new bool[11];
        }

        public bool[] MeasuredDataInputBoxesState { get; private set; }

        public void SetInputBoxState(int index, bool value)
        {
            MeasuredDataInputBoxesState[index] = value;
        }

        private static AppState CreateStateInstanceAndReturn()
        {
            var newState = new AppState();
            _appStateInternal = newState;
            return newState;
        }
    }
}
