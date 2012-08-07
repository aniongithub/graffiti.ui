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
    public sealed class ResourceDictionary: IDictionary<string, object>
    {
        private readonly Dictionary<string, object> d = new Dictionary<string, object>();
        
        #region IDictionary<string,object> Members

        public void Add(string key, object value)
        {
            d.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return d.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return d.Keys; }
        }

        public bool Remove(string key)
        {
            return d.Remove(key);
        }

        public bool TryGetValue(string key, out object value)
        {
            return d.TryGetValue(key, out value);
        }

        public ICollection<object> Values
        {
            get { return d.Values; }
        }

        public object this[string key]
        {
            get { return d[key]; }
            set { d[key] = value; }
        }

        #endregion

        #region ICollection<KeyValuePair<string,object>> Members

        public void Add(KeyValuePair<string, object> item)
        {
            (d as ICollection<KeyValuePair<string, object>>).Add(item);
        }

        public void Clear()
        {
            d.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return (d as ICollection<KeyValuePair<string, object>>).Contains(item);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            (d as ICollection<KeyValuePair<string, object>>).CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return d.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return (d as ICollection<KeyValuePair<string, object>>).Remove(item);
        }

        #endregion

        #region IEnumerable<KeyValuePair<string,object>> Members

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return d.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        internal IResourceTreeNode Owner { get; set; }
    }

    public static class ResourceDictionaryExtensions
    {
        public static T Get<T>(this ResourceDictionary resourceDictionary, string name)
        {
            if (resourceDictionary == null)
                return default(T);

            object result;
            return !resourceDictionary.TryGetValue(name, out result) ? 
                resourceDictionary.Owner.Parent != null ?
                    Get<T>(resourceDictionary.Owner.Parent.Resources, name) :
                    default(T) : 
                (T) result;
        }
    }
}