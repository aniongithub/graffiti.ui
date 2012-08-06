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

using System.Collections.Generic;

namespace Graffiti.UI
{
    public enum Trigger
    { 
    }

    public sealed class Triggers: IDictionary<Trigger, Setters>
    {
        #region IDictionary<Trigger,Setters> Members

        public void Add(Trigger key, Setters value)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsKey(Trigger key)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Trigger> Keys
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool Remove(Trigger key)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGetValue(Trigger key, out Setters value)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Setters> Values
        {
            get { throw new System.NotImplementedException(); }
        }

        public Setters this[Trigger key]
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        #endregion

        #region ICollection<KeyValuePair<Trigger,Setters>> Members

        public void Add(KeyValuePair<Trigger, Setters> item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(KeyValuePair<Trigger, Setters> item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(KeyValuePair<Trigger, Setters>[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public int Count
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool Remove(KeyValuePair<Trigger, Setters> item)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region IEnumerable<KeyValuePair<Trigger,Setters>> Members

        public IEnumerator<KeyValuePair<Trigger, Setters>> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}