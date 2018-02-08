using System;
using System.Collections.Generic;
//using Couchbase;
//using Couchbase.Core;
//using Couchbase.N1QL;

namespace Starter.Models
{
    public class ProfileRepository
    {
        //TODO: private readonly IBucket _bucket;

        public ProfileRepository()
        {
            //TODO: _bucket = ClusterHelper.GetBucket("hello-couchbase");
        }

        public Profile GetProfileByKey(string key)
        {
            throw new NotImplementedException("Implement GetProfileByKey with bucket Get");
        }

        public List<Profile> GetAll()
        {
            throw new NotImplementedException("Implement GetAll with a N1QL query");
        }

        public void Save(Profile model)
        {
            throw new NotImplementedException("Implement Save with bucket Upsert");
        }

        public void Delete(string key)
        {
            throw new NotImplementedException("Implement Delete with bucket Remove");
        }
    }
}