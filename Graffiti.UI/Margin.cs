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

namespace Graffiti.UI
{
    public struct Margin
    {
        public Margin(float amount)
        {
            _top = _bottom = _left = _right = amount;
        }

        public Margin(float left, float top, float right, float bottom)
        {
            _left = left;
            _top = top;
            _right = right;
            _bottom = bottom;
        }

        private readonly float _top;
        public float Top
        {
            get { return _top; }
        }

        private readonly float _bottom;
        public float Bottom
        {
            get { return _bottom; }
        }

        private readonly float _left;
        public float Left
        {
            get { return _left; }
        }

        private readonly float _right;
        public float Right
        {
            get { return _right; }
        }
    }
}