using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest5
{
    internal class PlayerEnumerator : IEnumerator<Player>
    {
        private List<Player> list;
        private int currentIndex = -1;
        private Player currentPlayer;

        public PlayerEnumerator(List<Player> players)
        {
            list = players;
        }
        public Player Current
        {
            get { return currentPlayer; }
        }
        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++currentIndex >= list.Count)
            {
                return false;
            }
            else
            {
                currentPlayer = list[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
