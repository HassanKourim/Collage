// It's some codes that I save it here, to go back to them again

// pointer 
// That's loop to sum the prev. and current value to print.
  for (int c = 0, prev = 0, current = 1; c <= 10; ++c){
    Console.Write(prev + " ");
    int sum = prev + current;
    prev = current;
    current = sum;
  }

