#!/usr/bin/env python
# Copyright (c) 2013-2014 Turbulenz Limited

# pylint:disable=C0330

from sys import argv, stdout
from json import loads as load_json, dumps as dump_json
from yaml import load as load_yaml
from os.path import join as path_join, exists as path_exists, splitext, basename, normpath, getmtime, dirname
from os import makedirs, listdir, environ, unlink as remove_file, getenv as os_getenv, walk as os_walk, rmdir
from shutil import copy2 as copy_file
from hashlib import md5
from base64 import urlsafe_b64encode
from subprocess import Popen, PIPE, STDOUT
from platform import system, machine
from threading import Thread, Lock
from time import sleep
