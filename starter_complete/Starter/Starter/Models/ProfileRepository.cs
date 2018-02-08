using System;
using System.Collections.Generic;
using Couchbase;
using Couchbase.Core;
using Couchbase.N1QL;

namespace Starter.Models
{
    // tag::ProfileRepository[]
    public class ProfileRepository
    {
        private readonly IBucket _bucket;

        public ProfileRepository()
        {
            _bucket = ClusterHelper.GetBucket("hello-couchbase");
        }

        public Profile GetProfileByKey(string key)
        {
            var profile = _bucket.Get<Profile>(key).Value;
            profile.Id = key;
            return profile;
        }

        public List<Profile> GetAll()
        {
            var request = QueryRequest.Create(@"
                SELECT META().id, hc.*
                FROM `hello-couchbase` as hc
                WHERE type='Profile';");
            request.ScanConsistency(ScanConsistency.RequestPlus);
            var response = _bucket.Query<Profile>(request);
            return response.Rows;
        }

        public void Save(Profile model)
        {
            if (string.IsNullOrEmpty(model.Id))
                model.Id = Guid.NewGuid().ToString();

            var doc = new Document<dynamic>
            {
                Id = model.Id,
                Content = new {
                    model.FirstName,
                    model.LastName,
                    model.Type
                }
            };
            _bucket.Upsert(doc);
        }

        public void Delete(string key)
        {
            _bucket.Remove(key);
        }
    }
    // end::ProfileRepository[]
}