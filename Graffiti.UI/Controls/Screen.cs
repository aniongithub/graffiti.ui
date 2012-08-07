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

using Microsoft.Xna.Framework;

namespace Graffiti.UI.Controls
{
    public sealed class Screen : ContentControl
    {
        private Rectangle _rectangle;
        private bool _measureDirty = true;
        public override Rectangle Measure()
        {
            if (_measureDirty)
            {
                _rectangle = new Rectangle(0, 0, Width, Height);
                _measureDirty = false;
            }
            return _rectangle;
        }

        public override void Arrange()
        {
            throw new System.NotImplementedException();
        }

        private int _width;
        public int Width
        {
            get { return _width; }
            set 
            { 
                _width = value;
                _measureDirty = true;
            }
        }

        private int _height;
        public int Height
        {
            get { return _height; }
            set 
            { 
                _height = value;
                _measureDirty = true;
            }
        }
    }
}