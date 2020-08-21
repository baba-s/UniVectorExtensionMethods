# UniVectorExtensionMethods

Vector2、Vector3 型の拡張メソッド

## Vector2

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var vector2 = new Vector2( 1.1f, 2.2f );

        // 要素を四捨五入した Vector2 を取得します
        Debug.Log( vector2.Round() ); // 1.0, 2.0
    }
}
```

### Vector3

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var vector3 = new Vector3( 1.1f, 2.2f, 3.3f );

        // 要素を四捨五入した Vector3 を取得します
        Debug.Log( vector3.Round() ); // 1.0, 2.0, 3.0
    }
}
```
