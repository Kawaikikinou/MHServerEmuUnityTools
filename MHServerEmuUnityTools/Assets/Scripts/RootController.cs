using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RootController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _cubePrefab;

        public void OnClickGenerate()
        {
            InstanciateCubes();
        }

        void InstanciateCubes()
        {
            for (int i = 0; i < transform.childCount; i++)
                Destroy(transform.GetChild(i).gameObject);

            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            var size = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f));
            Transform cubeTransform = Instantiate(_cubePrefab, position, Quaternion.identity, transform).GetComponent<Transform>();
            cubeTransform.transform.localScale = size;

            position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            size = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f));
            cubeTransform = Instantiate(_cubePrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Transform>();
            cubeTransform.transform.localScale = size;
        }
    }
}