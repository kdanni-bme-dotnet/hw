#!/bin/bash
git add -A
git commit -a -m "Comment: $1"
git push $GITURL_HW
