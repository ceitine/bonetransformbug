Weird bug with SetBoneTransform that occurs on clientside ModelEntities.
File code/TestEntity.cs, is the modelentity using SetBoneTransform.

There are 2 TestEntities. One of them has the SetPos variable set to true. 
```cs
var first = new TestEntity()
{
	Position = new Vector3( 100, 0, 200 )
};

var second = new TestEntity()
{
	Position = new Vector3( -100, 0, 200 ),
	SetPos = true
};
```

When SetPos is true,
```cs
var pos = Position;
Position = 0;
Position = pos;
```
is called after SetBoneTransform.