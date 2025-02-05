using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magrathea.CustomNode
{

    [ExecuteAlways]
    public class RPComponent : MonoBehaviour
    {
        public static event System.Action OnExport;

        public static void InvokeExport()
        {
            OnExport?.Invoke();
        }

        private void OnEnable()
        {
            OnExport += HandleExport;
        }

        private void OnDisable()
        {
            OnExport -= HandleExport;
        }

        public virtual void HandleExport()
        {
            Debug.Log("handling export for component " + name);
        }

        public virtual string Type => "customnode";

        public virtual JProperty Serialized => null;
    }

}
