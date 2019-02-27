using System;

namespace Aldrigos.UltraUpdater.Data {
    [Serializable]
    public abstract class AbstractFileUpdate {
        public string Name { get; set; }

        protected AbstractFileUpdate( string name ) {
            Name = name;
        }

        public override bool Equals( object obj ) {
            var o = obj as AbstractFileUpdate;
            if( o == null ) return false;
            return Equals( o );
        }

        public abstract bool Equals( AbstractFileUpdate o );

        public abstract int CountFiles();
    }
}
