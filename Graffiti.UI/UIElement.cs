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
using Graffiti.Core.Rendering;
using Microsoft.Xna.Framework;

namespace Graffiti.UI
{
    public abstract class UIElement: Drawable, IResourceTreeNode, IUIElementNode
    {
        protected UIElement()
        {
            Enabled = true;
        }

        public Style Style { get; set; }
        public bool Enabled { get; set; }

        public void Trigger(Trigger trigger)
        {
            throw new NotImplementedException();
        }

        #region IResourceTreeNode Members

        IResourceTreeNode IResourceTreeNode.Parent { get; set; }

        private ResourceDictionary _resources;
        ResourceDictionary IResourceTreeNode.Resources
        {
            get
            {
                return _resources;
            }
            set
            {
                _resources = value;
                if (_resources != null)
                    _resources.Owner = this;
            }
        }

        #endregion

        #region IUIElementNode Members

        IUIElementNode IUIElementNode.Parent { get; set; }

        public string Name { get; set; }

        #endregion

        public Margin Margin { get; set; }
        public Padding Padding { get; set; }

        public abstract Rectangle Measure();
        public abstract void Arrange();
    }

    public static class UIElementExtensions
    {
        public static UIElement Find(this UIElement current, string name)
        {
            if (current == null)
                return null;

            if (current.Name == name)
                return current;

            return Find((UIElement)(current as IUIElementNode).Parent, name);
        }
    }
}