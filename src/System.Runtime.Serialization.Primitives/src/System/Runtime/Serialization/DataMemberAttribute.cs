// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Runtime.Serialization
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class DataMemberAttribute : Attribute
    {
        private string _name;
        private bool _isNameSetExplicitly;
        private int _order = -1;
        private bool _isRequired;
        private bool _emitDefaultValue = true;

        public DataMemberAttribute()
        {
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; _isNameSetExplicitly = true; }
        }

        public bool IsNameSetExplicitly
        {
            get { return _isNameSetExplicitly; }
        }

        public int Order
        {
            get { return _order; }
            set
            {
                if (value < 0)
                    throw new InvalidDataContractException(SR.OrderCannotBeNegative);
                _order = value;
            }
        }

        public bool IsRequired
        {
            get { return _isRequired; }
            set { _isRequired = value; }
        }

        public bool EmitDefaultValue
        {
            get { return _emitDefaultValue; }
            set { _emitDefaultValue = value; }
        }
    }
}
