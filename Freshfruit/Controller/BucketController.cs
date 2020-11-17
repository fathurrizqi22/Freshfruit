using Freshfruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Freshfruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.Insert(fruit);
                eventListener.onSucceed("Yey, berhasil ditambahkan");
            }
        }
            public bool bucketIsOverload()
            {
                return bucket.countItems() >= bucket.getCapacity();
            }


            public void removeFruit(Fruit fruit)
            {
                for (int itemPosisition = 0; itemPosisition < bucket.countItems(); itemPosisition++)
                {
                if (bucket.findAll().ElementAt(itemPosisition).getName() == fruit.name)
                    {
                        bucket.remove(itemPosisition);
                    eventListener.onSucceed("Yey, berhasil dihapus");
                    }
                }
            }

            public List<Fruit> findAll()
            {
                return this.bucket.findAll();
            }
        
    }
}
