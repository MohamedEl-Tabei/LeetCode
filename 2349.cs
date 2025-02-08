public class NumberContainers {
    private Dictionary<int, int> container;
    private Dictionary<int, int> containerX;
    public NumberContainers() {
        container = new Dictionary<int, int>();
        containerX = new Dictionary<int, int>();
    }

    public void Change(int index, int number) {
        container[index] = number;
        containerX.Clear();
    }
    /*
        - When calling Find for the first time, or after clearing containerX, we rebuild the data:
          - The key is the value (number).
          - The value is the smallest index that holds this number.
    */
    public int Find(int number) {
        int v;
        if (containerX.Count == 0) {
            foreach(int k in container.Keys)
            {
                v = container[k];
                if (containerX.ContainsKey(v))
                    containerX[v] = containerX[v] < k ? containerX[v] : k;
                else
                    containerX.Add(v, k);
            }
        }
        return containerX.ContainsKey(number) ? containerX[number] : -1;
    }
}
