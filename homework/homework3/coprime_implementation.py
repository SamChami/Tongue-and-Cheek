import unittest

def areRelativelyPrime(a, b):
    if a is 0:
        return (b is 1 or b is -1)
    if b is 0:
        return (a is 1 or a is -1)

    gcd= GCD(a,b)
    return gcd is 1 or gcd is -1

def GCD(a,b):
    a = abs(a)
    b = abs(b)

    if a is 0:
        return b
    if b is 0:
        return a

    while True:
        remainder = a % b
        if remainder is 0:
            return b
        a = b
        b = remainder


class TestRelative(unittest.TestCase):
    def test_generic(self):
        # Generic Tests
        self.assertEqual(areRelativelyPrime(12, 13), True)
        self.assertEqual(areRelativelyPrime(12, 14), False)

        # Tests consistency on number ordering
        self.assertEqual(areRelativelyPrime(12, 13), areRelativelyPrime(13, 12))
        self.assertEqual(areRelativelyPrime(12, 14), areRelativelyPrime(14, 12))

    def test_edge(self):
        # Edge cases
        self.assertEqual(areRelativelyPrime(0, 1), True)
        self.assertEqual(areRelativelyPrime(-1, 1), True)
        self.assertEqual(areRelativelyPrime(0, 0), False)
        self.assertEqual(areRelativelyPrime(0, 1000000), False)

    def test_random(self):
        # Random Selection
        self.assertEqual(areRelativelyPrime(2, -2), False)
        self.assertEqual(areRelativelyPrime(8888, 7777), False)
        self.assertEqual(areRelativelyPrime(213421, 456456), False)
        self.assertEqual(areRelativelyPrime(5, 275), False)
        self.assertEqual(areRelativelyPrime(1000000, 11), True)
        self.assertEqual(areRelativelyPrime(88888, 7777), True)
        self.assertEqual(areRelativelyPrime(100000, 100001), True)

    def test_input(self):
        # Incorrect Inputs
        self.assertRaises(TypeError, areRelativelyPrime('a', 100001))
        self.assertRaises(TypeError, areRelativelyPrime('a', 'b'))
        self.assertRaises(TypeError, areRelativelyPrime(100001, 'b'))
        self.assertRaises(OutOfRangeError, areRelativelyPrime(2000000, -2000000))

if __name__ == '__main__':
    unittest.main()
