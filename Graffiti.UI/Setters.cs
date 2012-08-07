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

using System;
using System.Collections;
using System.Collections.Generic;

namespace Graffiti.UI
{
    public sealed class Setters: IList<Action<UIElement>>
    {
        private readonly List<Action<UIElement>> _list = new List<Action<UIElement>>();

        #region IList<Action<UIElement>> Members

        public int IndexOf(Action<UIElement> item)
        {
            return _list.IndexOf(item);
        }
        public void Insert(int index, Action<UIElement> item)
        {
            _list.Insert(index, item);
        }
        public void Add(Action<UIElement> item)
        {
            _list.Add(item);
        }
        public void Clear()
        {
            _list.Clear();
        }
        public bool Contains(Action<UIElement> item)
        {
            return _list.Contains(item);
        }
        public void CopyTo(Action<UIElement>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }
        public int Count
        {
            get { return _list.Count; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        
        public bool Remove(Action<UIElement> item)
        {
            return _list.Remove(item);
        }
        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Action<UIElement> this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        #endregion

        #region IEnumerable<Action<UIElement>> Members

        public IEnumerator<Action<UIElement>> GetEnumerator()
        {
            return _list.GetEnumerator();
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