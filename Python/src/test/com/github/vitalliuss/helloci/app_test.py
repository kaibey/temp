import unittest
from app import App
from empty_class import EmptyClass

class AppTest(unittest.TestCase):

    def test_should_be_passed(self):
        self.assertTrue(True)

    def test_should_be_failed(self):
        self.assertTrue(False)

    @unittest.skip("Not implemented yet")
    def test_should_be_skipped(self):
        self.assertTrue(True)

    def test_another_method(self):
        App.do_nothing()

    def test_another_class(self):
        EmptyClass.empty_method()

if __name__ == '__main__':
    unittest.main()