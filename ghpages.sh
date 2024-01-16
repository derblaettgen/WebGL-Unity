#!/bin/sh
git add .
git commit -m 'Build DIST'
git subtree push --prefix dist origin gh-pages

# https://gist.github.com/cobyism/4730490