<?php

require 'wishlist.php';
require 'presents.php';
require 'Present.php';

function guessGifts($wishlist, $presents) {
  $possibilities = [];
  foreach ($presents as $present) {
    (new Present($present))->findMatch($wishlist, $possibilities);
  }

  return $possibilities;
}

print_r(guessGifts($wishlist, $presents));
