using System.Collections;

namespace MyArray.Library
{

    public class CustomArray : IEnumerable<int>
    {
        private int[] _array;
        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public CustomArray(int capacity) {
            if (capacity <= 0) throw new ArgumentException();
            _array = new int[capacity];
        }

        public int Length => _array.Length;

        public void SetRandomValues()
        {
            var random = new Random();
            foreach (var item in _array)
            {        
                _array[item] = random.Next();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return ((IEnumerable<int>)_array).GetEnumerator();
        }
    }
}