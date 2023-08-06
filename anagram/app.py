import unittest

def is_anagram(s, t):
    """ Determines if the two given strings are anagrams """
    return ''.join(sorted(s)) == ''.join(sorted(t))

""" Tests """
class Tests(unittest.TestCase):
    def test_is_not_anagram(self):
        self.assertEqual(False, is_anagram('barbie', 'oppenheimer'))
    
    def test_is_anagram(self):
        self.assertEqual(True, is_anagram('test', 'stet'))
        self.assertEqual(True, is_anagram('care', 'race'))
        self.assertEqual(True, is_anagram('moonstarer', "astronomer"))

if __name__ == '__main__':
    unittest.main()