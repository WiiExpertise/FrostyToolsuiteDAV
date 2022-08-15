using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.QueryResultHubEntityData))]
	public class QueryResultHubEntity : LogicEntity, IEntityData<FrostySdk.Ebx.QueryResultHubEntityData>
	{
		public new FrostySdk.Ebx.QueryResultHubEntityData Data => data as FrostySdk.Ebx.QueryResultHubEntityData;
		public override string DisplayName => "QueryResultHub";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public QueryResultHubEntity(FrostySdk.Ebx.QueryResultHubEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

