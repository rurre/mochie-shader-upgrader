using UnityEngine;

namespace Mochie.ShaderUpgrader
{
    public abstract class PropertyActionBase
    {
        public string SourcePropertyName { get; private set; }
        public string TargetPropertyName { get; private set; }
        public SerializedMaterialPropertyType PropertyType { get; private set; }
        
        protected PropertyActionBase(string sourcePropertyName, string targetPropertyName, SerializedMaterialPropertyType propertyType)
        {
            SourcePropertyName = sourcePropertyName;
            TargetPropertyName = targetPropertyName;
            PropertyType = propertyType;
        }

        public abstract void RunAction(MaterialContext materialContext);
    }
}