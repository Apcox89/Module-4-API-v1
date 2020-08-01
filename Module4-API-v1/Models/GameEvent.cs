using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module4_API_v1.Models
{
    [Serializable]
    //for use with json + dependency injection
    public class GameEvent : System.Collections.IEnumerable
    {
        private Game[] _gamescene;

        public GameEvent(Game[] gArray)
        {
            _gamescene = new Game[gArray.Length];

            for (int i = 0; i < gArray.Length; i++)
            {
                _gamescene[i] = gArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public GameEnum GetEnumerator()
        {
            return new GameEnum(_gamescene);
        }
    }

    public class GameEnum : IEnumerator
    {
        public Game[] _gamescene;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public GameEnum(Game[] list)
        {
            _gamescene = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _gamescene.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Game Current
        {
            get
            {
                try
                {
                    return _gamescene[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}