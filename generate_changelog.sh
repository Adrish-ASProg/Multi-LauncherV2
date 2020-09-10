#!/bin/bash

# Commits will be included only if created after this tag
FROM_TAG="v0.5.0"

# Format outputted by git log command
# %s: Commit subject
# %cd: Commit date
# %H: Commit hash
LOG_FORMAT=" - %s ([_%cd_](https://github.com/Adrish-ASProg/Multi-LauncherV2/commit/%H))"

FULL_CHANGELOG="Multi-Launcher V2 - Changelog\n"
FULL_CHANGELOG="$FULL_CHANGELOG----------------------\n"

while read TAG ; do

    FULL_CHANGELOG="$FULL_CHANGELOG\n"

    if [ $NEXT ];then
         FULL_CHANGELOG="$FULL_CHANGELOG## [$NEXT](https://github.com/Adrish-ASProg/Multi-LauncherV2/releases/tag/$NEXT)\n"
         GITLOG_RESULT="$(git log --no-merges --format="$LOG_FORMAT" --invert-grep --grep='Update CHANGELOG.md' --date="short" $FROM_TAG..$NEXT)"
         FULL_CHANGELOG="$FULL_CHANGELOG$GITLOG_RESULT\n"
    fi

    if [ "$TAG" == "$FROM_TAG" ];then
      break
    fi;
    NEXT=$TAG
done <<< "$(git tag -l --sort=-taggerdate | grep -E "^v([0-9]+\.)+[0-9]+")"

echo -e "$FULL_CHANGELOG" > CHANGELOG.md && \
echo -e "#\n##\n### Changelog successfully generated\n##\n#"