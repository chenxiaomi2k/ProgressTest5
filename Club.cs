using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest5
{
    internal class Club : IEnumerable<Player>
    {
        public event ActionDelegate AttackEvent;
        public event ActionDelegate DefenseEvent;

        private List<Player> _players;

        public Club()
        {
            _players = new List<Player>();
        }

        public void Add(Player p)
        {
            _players.Add(p);
        }

        public void RaiseAtkEvent()
        {
            AttackEvent.Invoke();
        }
        public void RaiseDefEvent()
        {
            DefenseEvent.Invoke();
        }
        public IEnumerator<Player> GetEnumerator()
        {
            return new PlayerEnumerator(_players);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
