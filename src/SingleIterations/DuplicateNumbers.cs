using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleIterations {

	public class DuplicateNumbers {

		private IList<int> _list;

		public DuplicateNumbers(int from, int to) {
			_list = GenerateList(from, to);
			InjectRandomNumber(_list, from, to);
		}

		public IEnumerable<KeyValuePair<int, int>> Run() {
			Dictionary<int, int> map = new Dictionary<int, int>();
			for (int i = 0; i < _list.Count; ++i) {
				if (map.TryGetValue(_list[i], out int foundVal)) 
					map[_list[i]] = ++foundVal;
				else
					map.Add(_list[i], 1);
			}

			return map.Where(x => x.Value > 1);
		}

		private IList<int> GenerateList(int from, int to) {
			List<int> list = new List<int>();
			for (int i = from; i <= to; ++i)
				list.Add(i);

			return list;
		}

		private void InjectRandomNumber(IList<int> list, int from, int to) {
			Random rand = new Random();
			int randomIndex = rand.Next(from, to);
			int randomNum = rand.Next(from, to);

			list[randomIndex] = randomNum;
		}

	}

}