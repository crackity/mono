// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Class: TypeUnloadedException
**
**
** Purpose: Exception class for attempt to access an unloaded class
**
**
=============================================================================*/

namespace System {
    
    using System.Runtime.Serialization;

[System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public class TypeUnloadedException : SystemException {
        public TypeUnloadedException() 
            : base(Environment.GetResourceString("Arg_TypeUnloadedException")) {
            SetErrorCode(__HResults.COR_E_TYPEUNLOADED);
        }
    
        public TypeUnloadedException(String message) 
            : base(message) {
            SetErrorCode(__HResults.COR_E_TYPEUNLOADED);
        }
    
        public TypeUnloadedException(String message, Exception innerException) 
            : base(message, innerException) {
            SetErrorCode(__HResults.COR_E_TYPEUNLOADED);
        }

        //
        // This constructor is required for serialization;
        //
        protected TypeUnloadedException(SerializationInfo info, StreamingContext context) : base (info, context) {
        }
    }
}

