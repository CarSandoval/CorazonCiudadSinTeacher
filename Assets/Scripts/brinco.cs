namespace Mapbox.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Mapbox.Unity.Location;
    using Mapbox.Unity.Map;

    public class brinco : MonoBehaviour
    {

        public float velocidad = 1;
        public float amplitud = 1;
        public float latitud;
        public float longitud;
        int cont = 0;

        bool _isInitialized;

        ILocationProvider _locationProvider;
        ILocationProvider LocationProvider
        {
            get
            {
                if (_locationProvider == null)
                {
                    _locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider;
                }

                return _locationProvider;
            }
        }
        // Start is called before the first frame update

        void Start()
        {
            LocationProviderFactory.Instance.mapManager.OnInitialized += () => _isInitialized = true;
            cont = (int)Random.Range(0,360);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {   
            
        }

        void LateUpdate()
        {
            if (_isInitialized)
            {
                var map = LocationProviderFactory.Instance.mapManager;
                transform.localPosition = map.GeoToWorldPosition(new Utils.Vector2d(latitud, longitud));
                transform.transform.Translate(0, amplitud * Mathf.Sin((float)cont * velocidad), 0);
                cont++;
                //transform.localPosition = map.GeoToWorldPosition(new Utils.Vector2d(60.19188, 24.9685822));
                //transform.localPosition = map.GeoToWorldPosition(new Utils.Vector2d(20.6799374, -103.3496198));
            }
        }
    }
}