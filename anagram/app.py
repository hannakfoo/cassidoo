import unittest

def is_anagram(s, t):
    """Determines if the two given strings (s and t) are anagrams"""
    return ''.join(sorted(s)) == ''.join(sorted(t))

"""Tests"""
class Tests(unittest.TestCase):
    def test_is_not_anagram(self):
        self.assertEqual(False, is_anagram('barbie', 'oppenheimer'))
    
    def test_is_anagram(self):
        self.assertEqual(True, is_anagram('test', 'stet'))
        self.assertEqual(True, is_anagram('care', 'race'))
        self.assertEqual(True, is_anagram('moonstarer', "astronomer"))
        self.assertEqual(True, is_anagram('kakstoel', "koelkast"))
        self.assertEqual(True, is_anagram('aalscholver', "schollevaar"))

if __name__ == '__main__':
    unittest.main()