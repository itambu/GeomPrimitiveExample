using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Transactions;

namespace ConsoleApp26
{
    public class Department : ICollection<IOperation>
    {
        public event EventHandler<IOperation> AfterAddNew;

        public event EventHandler<IOperation> BeforeAddNew;

        protected virtual void OnBeforeAddNew(object? sender, IOperation? operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }
            BeforeAddNew?.Invoke(sender, operation);
        }

        protected virtual void OnAfterAddNew(object? sender, IOperation? operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }
            AfterAddNew?.Invoke(sender, operation);
        }

        public Department(string name, IOperation teamLead, ICollection<IOperation>? subordinates)
        {
            Name = name;
            TeamLead = teamLead;
            _Subordinates = subordinates;
        }

        public string Name { get; set; }
        public IOperation TeamLead { get; set; }
        protected ICollection<IOperation>? _Subordinates { get; private set; }

        public int Count
        {
            get 
            {
                var c = _Subordinates != null ? _Subordinates.Count : 0;
                return TeamLead != null ? c + 1 : c;
            }
        }

        public bool IsReadOnly => false;

        public void Add(IOperation item)
        {
            if (item == null) throw new ArgumentNullException("item");

            if (item== TeamLead)
            {
                throw new InvalidOperationException($"{nameof(item)} is already team lead");
            }

            if (_Subordinates==null)
            {
                throw new InvalidOperationException($"No object in {nameof(_Subordinates)} property");
            }

            if (_Subordinates.Contains(item))
            {
                throw new InvalidOperationException($"{nameof(item)} is already in department");
            }

            OnBeforeAddNew(this, item);
            _Subordinates.Add(item);
            OnAfterAddNew(this, item);
        }

        public void CleanPremice()
        {
            foreach (var emp in _Subordinates!)
            {
                emp.Perform();
            }
            TeamLead.Perform();
        }

        public void Clear()
        {
            _Subordinates!.Clear();
        }

        public bool Contains(IOperation item)
        {
            return _Subordinates!.Contains(item) || (TeamLead == item);
        }

        public void CopyTo(IOperation[] array, int arrayIndex)
        {
            _Subordinates!.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOperation> GetEnumerator()
        {
            yield return TeamLead;
            foreach (var i in _Subordinates!)
            {
                yield return i;
            }
        }

        public IEnumerable<IOperation> Backward()
        {
            for(int c = _Subordinates!.Count; c>= 0; c--)
            {
                yield return _Subordinates.ElementAt(c);
            }

            yield return TeamLead;
        }

        public bool Remove(IOperation item)
        {
            return _Subordinates!.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}