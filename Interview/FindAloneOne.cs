using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    /// <summary>
    /// 给定一个长度为2N+1的数组
    /// 其中数组中有N+1个不同的数字
    /// 找出其中那个孤独的孩子
    /// </summary>
    class FindAloneOne
    {
        private static List<int> InitData(int N)
        {
            List<int> retVal = new List<int>();
            var addRange = Enumerable.Range(1, N+1).OrderBy(num => Guid.NewGuid()).ToList();
            retVal.AddRange(addRange);
            retVal.AddRange(addRange);
            Console.WriteLine("Alone one is:{0}",addRange.Last());
            retVal.RemoveAt(retVal.Count - 1);
            return retVal.OrderBy(num => Guid.NewGuid()).ToList();
        }

        /// <summary>
        /// 方法：
        /// 利用位运算,这样可以保证空间复杂度为1（只使用了一个int大小的空间）时间复杂度为 2N（只遍历了一遍数组）
        /// 1 ^ 1 = 0 
        /// 11 ^ 1 = 10
        /// 10 ^ 11 = 1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int DoFind(int N)
        {
            List<int> data = InitData(N);
            int result = 0;
            foreach (int num in data)
            {
                result = result ^ num;
            }
            Console.WriteLine("The alone one is :{0}",result);
            return result;
        }

        /// <summary>
        /// 方法：
        /// 利用位运算,这样可以保证空间复杂度为1（只使用了一个int大小的空间）时间复杂度为 2N（只遍历了一遍数组）
        /// 1 ^ 1 = 0 
        /// 11 ^ 1 = 10
        /// 10 ^ 11 = 1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int DoFind2(int N)
        {
            List<int> data = InitData(N);
            HashSet<int> findSet = new HashSet<int>();
            foreach (int num in data)
            {
                if (findSet.Contains(num))
                {
                    findSet.Remove(num);
                }
                else
                {
                    findSet.Add(num);
                }
            }
            Console.WriteLine("The alone count is :{0}", findSet.Count);
            foreach (int num in findSet)
            {
                Console.WriteLine("The alone one is :{0}",findSet.First());
            }
            return findSet.First();
        }
    }
}
