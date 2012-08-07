#region License and Copyright Notice
// Copyright (c) 2010 Ananth Balasubramaniam
// All rights reserved.
// 
// The contents of this file are made available under the terms of the
// Eclipse Public License v1.0 (the "License") which accompanies this
// distribution, and is available at the following URL:
// http://www.opensource.org/licenses/eclipse-1.0.php
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either expressed or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// By using this software in any fashion, you are agreeing to be bound by the
// terms of the License.
#endregion

using System.Collections;
using System.Collections.Generic;

namespace Graffiti.UI
{
    public enum Trigger
    { 
        None,
        Selected,
        Deselected,
        Activated,
        Disabled,
        Enabled,
        SwipeLeft,
        SwipeRight,
        SwipeUp,
        SwipeDown,
        PinchIn,
        PinchOut
    }

    public sealed class Triggers: IDictionary<Trigger, Setters>
    {
        private readonly Dictionary<Trigger, Setters> _dictionary = new Dictionary<Trigger, Setters>();
        
        #region IDictionary<Trigger,Setters> Members

        public void Add(Trigger key, Setters value)
        {
            _dictionary.Add(key, value);
        }
        public bool ContainsKey(Trigger key)
        {
            return _dictionary.ContainsKey(key);
        }
        public ICollection<Trigger> Keys
        {
            get { return _dictionary.Keys; }
        }
        public bool Remove(Trigger key)
        {
            return _dictionary.Remove(key);
        }
        public bool TryGetValue(Trigger key, out Setters value)
        {
            return _dictionary.TryGetValue(key, out value);
        }
        public ICollection<Setters> Values
        {
            get { return _dictionary.Values; }
        }
        public Setters this[Trigger key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        #endregion

        #region ICollection<KeyValuePair<Trigger,Setters>> Members

        public void Add(KeyValuePair<Trigger, Setters> item)
        {
            (_dictionary as ICollection<KeyValuePair<Trigger,Setters>>).Add(item);
        }
        public void Clear()
        {
            _dictionary.Clear();
        }
        public bool Contains(KeyValuePair<Trigger, Setters> item)
        {
            return (_dictionary as ICollection<KeyValuePair<Trigger, Setters>>).Contains(item);
        }
        public void CopyTo(KeyValuePair<Trigger, Setters>[] array, int arrayIndex)
        {
            (_dictionary as ICollection<KeyValuePair<Trigger, Setters>>).CopyTo(array, arrayIndex);
        }
        public int Count
        {
            get { return _dictionary.Count; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool Remove(KeyValuePair<Trigger, Setters> item)
        {
            return (_dictionary as ICollection<KeyValuePair<Trigger, Setters>>).Remove(item);
        }

        #endregion

        #region IEnumerable<KeyValuePair<Trigger,Setters>> Members

        public IEnumerator<KeyValuePair<Trigger, Setters>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}