<template>
  <div class="container">
  <div class="shitty-tweets" v-for="shittyTweet in shittyTweets" :key="shittyTweet.id">
    <shitty-tweet
      :shittyTweet="shittyTweet"
      />
  </div> 
</div>
</template>

<script>
import ShittyTweet from './ShittyTweet';
import { mapState, mapActions } from 'vuex';

export default {
  name: 'AllTweets',
  components: {
    ShittyTweet,
  },
  computed: {
    ...mapState(['shittyTweets'])
  },
  created() {
    this.getAllTweetsFromApi();
  },
  methods: {
    ...mapActions([
      'getAllTweetsFromApi',
    ]),
  },  
}
</script>

<style>

</style>
