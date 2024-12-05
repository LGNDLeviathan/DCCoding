import unittest
import test_main

# Tests
suite = unittest.TestLoader().loadTestsFromModule(test_main)
unittest.TextTestRunner(verbosity=2).run(suite)

########
# Candidate to only edit below this line.
########

def process(input, operation):
    return 1